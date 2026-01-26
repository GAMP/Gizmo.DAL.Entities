namespace Gizmo.DAL.Entities
{
    /// <summary>
    /// Deposit transaction types.
    /// </summary>
    public enum DepositTransactionType
    {
        /// <summary>
        /// Deposit to an account.
        /// </summary>
        Deposit = 0,

        /// <summary>
        /// Withdraw from account.
        /// </summary>
        Withdraw = 1,

        /// <summary>
        /// Account charge.
        /// </summary>
        Charge = 2,

        /// <summary>
        /// Credit an amount to account.
        /// </summary>
        Credit = 3
    }
}
