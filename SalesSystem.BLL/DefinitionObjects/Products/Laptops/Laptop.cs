namespace SalesSystem.BLL.DefinitionObjects.Products.Laptops
{
    public class Laptop : Product
    {
        public Laptop()
        {
            AddAccesories();
        }

        private void AddAccesories()
        {
            var data = new DataRetrivalOperations.ProductdataRetrival();
            var hdd = data.GetParts(BOD.ProductAccesorries.HDD, 1, BOD.Units.TB);
            var Ram = data.GetParts(BOD.ProductAccesorries.Ram, 4, BOD.Units.GB);
            lstParts.Add(hdd);
            lstParts.Add(Ram);
        }
    }
}
