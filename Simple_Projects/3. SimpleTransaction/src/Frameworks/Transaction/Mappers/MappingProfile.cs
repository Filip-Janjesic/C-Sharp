using AutoMapper;
using System;
using Transaction.Framework.Data.Entities;
using Transaction.Framework.Domain;
using Transaction.Framework.Extensions;
using Transaction.Framework.Types;

namespace Transaction.Framework.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // AccountSummaryEntity → AccountSummary
            CreateMap<AccountSummaryEntity, AccountSummary>()
                .ForMember(dest => dest.Balance,
                           opt => opt.MapFrom(o => new Money(o.Balance, o.Currency.TryParseEnum<Currency>())));

            // AccountTransaction → AccountTransactionEntity
            CreateMap<AccountTransaction, AccountTransactionEntity>()
                .ForMember(dest => dest.Date,
                           opt => opt.MapFrom(o => DateTime.UtcNow))
                .ForMember(dest => dest.Description,
                           opt => opt.MapFrom(o => o.TransactionType == TransactionType.Deposit
                                ? StringResources.DepositDescription
                                : StringResources.WithdrawDescription))
                .ForMember(dest => dest.TransactionType,
                           opt => opt.MapFrom(o => o.TransactionType.ToString()))
                .ForMember(dest => dest.Amount,
                           opt => opt.MapFrom(o => o.Amount.Amount));

            // AccountSummary → AccountSummaryEntity
            CreateMap<AccountSummary, AccountSummaryEntity>()
                .ForMember(dest => dest.Balance,
                           opt => opt.MapFrom(o => o.Balance.Amount))
                .ForMember(dest => dest.Currency,
                           opt => opt.MapFrom(o => o.Balance.Currency.ToString()))
                .ForMember(dest => dest.AccountTransactions, opt => opt.Ignore());

            // AccountTransactionEntity → TransactionResult
            CreateMap<AccountTransactionEntity, TransactionResult>()
                .ForMember(dest => dest.IsSuccessful,
                           opt => opt.MapFrom(o => o.TransactionId > 0))
                .ForMember(dest => dest.Message,
                           opt => opt.MapFrom(o => o.TransactionId > 0
                                ? StringResources.TransactionSuccessfull
                                : StringResources.TransactionFailed))
                .ForMember(dest => dest.Balance, opt => opt.Ignore());

            // AccountSummary → TransactionResult
            CreateMap<AccountSummary, TransactionResult>()
                .ForMember(dest => dest.Balance, opt => opt.MapFrom(o => o.Balance))
                .ForMember(dest => dest.IsSuccessful, opt => opt.MapFrom(o => true))
                .ForMember(dest => dest.Message, opt => opt.MapFrom(o => StringResources.TransactionSuccessfull));

            // NOVO: TransactionModel → AccountTransaction uz SetIdentityAction
            CreateMap<TransactionModel, AccountTransaction>()
                .AfterMap<SetIdentityAction>();
        }
    }
}
