﻿using System.Xml.Serialization;

namespace CarDealer.DtoModels.Export
{
    [XmlType("car")]
    public class BmwCardsExportModel
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("model")]
        public string Model { get; set; }

        [XmlAttribute("travelled-distance")]
        public long Travalled { get; set; }
    }
}

//< cars >
//  < car id = "7" model = "1M Coupe" travelled - distance = "39826890" />
//  < car id = "16" model = "E67" travelled - distance = "476830509" />
//  < car id = "5" model = "E88" travelled - distance = "27453411" />
//  ...
//</ cars >

