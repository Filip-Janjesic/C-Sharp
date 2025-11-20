using AutoMapper;
using Transaction.Framework.Domain;
using Transaction.Framework.Types;

namespace Transaction.Framework.Mappers
{
    public class SetIdentityAction : IMappingAction<TransactionModel, AccountTransaction>
    {
        public void Process(TransactionModel source, AccountTransaction destination, ResolutionContext context)
        {
            destination.AccountNumber = source.Id;
            destination.TransactionType = source.TransactionType == "Deposit"
                                        ? TransactionType.Deposit
                                        : TransactionType.Withdraw;
            destination.Amount = new Money(source.Amount, Currency.USD);
        }
    }
}
