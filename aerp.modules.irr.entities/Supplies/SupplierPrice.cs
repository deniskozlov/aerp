// <copyright file="SupplierPrice.cs" project="advasoft.RetailControl.Core.BusinesEntities" company="Advasoft Development">
// Copyright (c) 2014 All Right Reserved, http://advasoft-dev.ru
// 
// This source is subject to the Microsoft Permissive License.
// Please see the License.txt file for more information.
// All other rights reserved.
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
// 
// </copyright>
// <author>Козлов Денис</author>
// <email>mailto:deniskozlov@outlook.com</email>
// <date>24.01.2014</date>
// <summary>Summary here....</summary>
namespace aerp.modules.irr.entities.Supplies
{
	using Classification;
	using entities;

	/// <summary>
	/// Цена постащика
	/// </summary>
	public class SupplierPrice : EntityBaseWithRegistrator
    {
		/// <summary>
		/// Идентификатор товара поставщика
		/// </summary>
        public int SupplierProductId { get; set; }
		/// <summary>
		/// Идентификатор валюты
		/// </summary>
        public int CurrencyId { get; set; }
		/// <summary>
		/// Товар постащика
		/// </summary>
		public SupplierProduct Product { get; set; }
		/// <summary>
		/// Валюта
		/// </summary>
        public Currency Currency { get; set; }
		/// <summary>
		/// Цена
		/// </summary>
        public decimal Price { get; set; } 
    }
}