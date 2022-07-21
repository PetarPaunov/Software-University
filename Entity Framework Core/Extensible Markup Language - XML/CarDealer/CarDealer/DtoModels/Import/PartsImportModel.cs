﻿using System.Xml.Serialization;

namespace CarDealer.DtoModels.Import
{
    [XmlType("Part")]
    public class PartsImportModel
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }

        [XmlElement("quantity")]
        public int  Quantity { get; set; }

        [XmlElement("supplierId")]
        public int SupplierId { get; set; }
    }
}

//< Part >
//        < name > Bonnet / hood </ name >
//        < price > 1001.34 </ price >
//        < quantity > 10 </ quantity >
//        < supplierId > 17 </ supplierId >
//    </ Part >
