namespace library_management_system
{
    public interface ILoanPolicy
    {
        string GetPolicyType();
        void ApplyLoanPolicy(Book book, Member member);
    }
}
