namespace OrderEngineP
{
    public interface Ipromotion
    {
         int ID { get; set; }
         string Name { get; set; }
         int UnitCount { get; set; }
         string SKuID { get; set; }
         int UnitPrice { get; set; }
        int GetPromptionPrice();
    }
}