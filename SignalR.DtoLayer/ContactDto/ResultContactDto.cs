﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ContactDto
{
    public class ResultContactDto
    {
        public int ContactID { get; set; }
        public string Location { get; set; }

        public int Phone { get; set; }
        public string Mail { get; set; }
        public string FooterDescription { get; set; }
    }
}
