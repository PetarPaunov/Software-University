﻿using System.Xml.Serialization;

namespace ProductShop.DataTransferObjects.Exports
{
    [XmlType("Product")]
    public class ProductsOutputModel
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("buyer")]
        public string BuyerName { get; set; }
    }
}
//< Product >
//    < name > TRAMADOL HYDROCHLORIDE </ name >
//    < price > 516.48 </ price >
//  </ Product >
