namespace Ambev.DeveloperEvaluation.Common.Entities
{
    public interface ISale
    {
        public string Id { get; }

        /// <summary>
        /// Obtém o número da venda.
        /// </summary>
        /// <returns>O número da venda.</returns>
        public string SaleNumber { get; }

    }
}
