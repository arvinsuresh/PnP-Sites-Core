﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.Model
{
    public partial class DataRowCollection : ProvisioningTemplateCollection<DataRow>
    {
        public DataRowCollection(ProvisioningTemplate parentTemplate) : base(parentTemplate)
        {

        }
    }
}