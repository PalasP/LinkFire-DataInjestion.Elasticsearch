﻿using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataInjestion.Elasticsearch.Business.Contract
{
    interface IGetData
    {
        CountResponse ReadDataFromElasticSearch();
    }
}
