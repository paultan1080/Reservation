using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MediaComposer.Data.Entities
{
    public partial class Provider
    {
        public Provider()
        {

        }

        public int ProviderId { get; set; }

        public string ProviderName { get; set; }


    }
}
