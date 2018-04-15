﻿using System;
using System.Collections.Generic;
using System.Linq;
using Swastika.Domain.Data.ViewModels;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json;
using Swastika.Crm.Lib.Models.Crm;

namespace Swastika.Crm.Lib.ViewModels.Crm.FrontEnd
{
    public class FECrmCustomerViewModel
        : ViewModelBase<SwastikaCrmContext, CrmCustomer, FECrmCustomerViewModel>
    {
        #region Properties

        #region Models
        [JsonProperty("customerId")]
        public int CustomerId { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }
        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
        [JsonProperty("createdDate")]
        public DateTime? CreatedDate { get; set; }
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
        #endregion

        #region Views

        #endregion

        #endregion

        #region Contructors

        public FECrmCustomerViewModel() : base()
        {
        }

        public FECrmCustomerViewModel(CrmCustomer model, SwastikaCrmContext _context = null, IDbContextTransaction _transaction = null) : base(model, _context, _transaction)
        {
        }

        #endregion

        #region Overrides

        #endregion

        #region Expands

        #endregion

    }
}
