// <copyright file="SupplierProduct.cs" project="advasoft.RetailControl.Core.BusinesEntities" company="Advasoft Development">
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
	using entities;
	using Production;

	/// <summary>
	/// Товар поставляемый поставщиком
	/// </summary>
	public class SupplierProduct : EntityBase
    {
		/// <summary>
		/// Идентификатор поставщика
		/// </summary>
        public int SupplierId { get; set; }
		/// <summary>
		/// Поставщик
		/// </summary>
        public Supplier Supplier { get; set; }
		/// <summary>
		/// Название товара поставщика
		/// </summary>
        public string Name { get; set; }
		/// <summary>
		/// Артикул поставщика
		/// </summary>
        public string Articul { get; set; }
		/// <summary>
		/// Идентификатор товара
		/// </summary>
        public int ProductId { get; set; }
		/// <summary>
		/// Товар
		/// </summary>
        public Product Product { get; set; }
    }
}