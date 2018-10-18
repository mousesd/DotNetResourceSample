using System;

namespace ConsoleApp3
{
    #region == ProductWorst1 ==
    public class ProductWorst1
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? ProductionDate { get; set; }

        public ProductWorst1()
        {
            this.Id = "";
            this.Name = "";
            this.ProductionDate = null;
        }

        public ProductWorst1(string id)
        {
            this.Id = id;
            this.Name = "";
            this.ProductionDate = null;
        }

        public ProductWorst1(string id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.ProductionDate = null;
        }

        public ProductWorst1(string id, string name, DateTime? productionDate)
        {
            this.Id = id;
            this.Name = name;
            this.ProductionDate = productionDate;
        }

        public override string ToString()
        {
            return $"Id:{Id}, Name={Name}, ProductionDate={ProductionDate}";
        }
    }
    #endregion

    #region == ProductWorst2 ==
    public class ProductWorst2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? ProductionDate { get; set; }

        public ProductWorst2()
        {
            this.Initialize("", "", null);
        }

        public ProductWorst2(string id)
        {
            this.Initialize(id, "", null);
        }

        public ProductWorst2(string id, string name)
        {
            this.Initialize(id, name, null);
        }

        public ProductWorst2(string id, string name, DateTime? productionDate)
        {
            this.Initialize(id, name, productionDate);
        }

        private void Initialize(string id, string name, DateTime? productionDate)
        {
            this.Id = id;
            this.Name = name;
            this.ProductionDate = productionDate;
        }

        public override string ToString()
        {
            return $"Id:{Id}, Name={Name}, ProductionDate={ProductionDate}";
        }
    }
    #endregion

    #region == Product ==
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime? ProductionDate { get; set; }

        public Product() { }
        public Product(string id) : this(id, "") { }
        public Product(string id, string name) : this(id, name, null) { }
        public Product(string id, string name, DateTime? productionDate)
        {
            this.Id = id;
            this.Name = name;
            this.ProductionDate = productionDate;
        }

        #region == Problem #2 ==
        //public Product(string name, DateTime? productionDate) : this("", name, productionDate) { }
        //public Product(string id, DateTime? productionDate) : this(id, "", productionDate) { } 
        #endregion

        public override string ToString()
        {
            return $"Id:{Id}, Name={Name}, ProductionDate={ProductionDate}";
        }
    }
    #endregion

    #region == ProductWithDefaultValueParams ==
    public class ProductWithDefaultValueParams
    {
        private readonly string id;
        private readonly string name;
        private readonly DateTime? productionDate;

        public ProductWithDefaultValueParams(string id = "", string name = "", DateTime? productionDate = null)
        {
            this.id = id;
            this.name = name;
            this.productionDate = productionDate;
        }

        public override string ToString()
        {
            return $"Id:{id}, Name={name}, ProductionDate={productionDate}";
        }
    } 
    #endregion
}
