namespace OrderEngineP
{
    public class OrderDetails
    {
        public int ItemCount { get; set; }

        public ISKUList SKUIds { get; set; }

        public Ipromotion Promotion { get; set; }

        public int Amount { get; set; }




        public OrderDetails(int count, ISKUList iSKU, Ipromotion promotionList, int amount)
        {
            ItemCount = count;
            SKUIds = iSKU;
            Promotion = promotionList;
            Amount = amount;
        }
    }
}