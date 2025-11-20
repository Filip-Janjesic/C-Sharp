using AutoMapper;
using Transaction.Framework.Domain;
using Transaction.Framework.Types;

namespace Transaction.Framework.Mappers
{
    public class SetIdentityAction : IMappingAction<TransactionModel, AccountTransaction>
    {
        public void Process(TransactionModel source, AccountTransaction destination, ResolutionContext context)
        {
            destination.AccountNumber = source.Id; // ili neki drugi property koji predstavlja account
            destination.TransactionType = Enum.TryParse<TransactionType>(source.TransactionType, out var type)
                                        ? type
                                        : TransactionType.Unknown; // default vrijednost
            destination.Amount = new Money(source.Amount, Currency.USD); // ili Currency iz source, ako postoji
        }
    }
}
