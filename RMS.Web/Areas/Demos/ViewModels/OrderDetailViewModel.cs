﻿using RMS.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace Restaurant.Web.Areas.Demos.ViewModels
{
    public class OrderDetailViewModel : OrderDetail
    {
        [Display(Name = "Order Detail ID")]
        public override int OrderDetailId
        {
            get
            {
                return base.OrderDetailId;
            }
            set
            {
                base.OrderDetailId = value;
            }
        }
        [Display(Name = "Oredered Item ID")]
        public override int ItemId
        {
            get { return base.ItemId; }
            set { base.ItemId = value; }
        }
        [Display(Name = "Unit Price of that item")]
        public override decimal UnitPrice
        {
            get { return base.UnitPrice; }
            set { base.UnitPrice = value; }
        }
        [Display(Name = "Discount")]
        public override decimal Discount
        {
            get { return base.Discount; }
            set { base.Discount = value; }
        }
        [Display(Name = "Total Amount")]
        public override decimal Total
        {
            get { return base.Total; }
            set { base.Total = value; }
        }
        [Display(Name = "Quantity")]
        public override decimal Quantity
        {
            get { return base.Quantity; }
            set { base.Quantity = value; }
        }
        [Display(Name = "Who have created this {0}?")]

        public override string CreatedBy
        {
            get => base.CreatedBy;
            set => base.CreatedBy = value;
        }
        [Display(Name = "When {0} was created?")]

        public override System.DateTime CreatedDate
        {
            get => base.CreatedDate;
            set => base.CreatedDate = value;
        }
        [Display(Name = "Who have updated this {0}?")]

        public override string UpdatedBy
        {
            get => base.UpdatedBy;
            set => base.UpdatedBy = value;
        }
        [Display(Name = "When {0} was updated?")]

        public override System.DateTime UpdatedDate
        {
            get => base.UpdatedDate;
            set => base.UpdatedDate = value;
        }
        [Display(Name = "Order ID of the order placed")]
        public override int OrderId
        {
            get => base.OrderId; set => base.OrderId = value;
        }

    }
}