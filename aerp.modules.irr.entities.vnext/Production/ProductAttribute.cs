// <copyright file="ProductAttribute.cs" project="advasoft.RetailControl.Core.BusinesEntities" company="Advasoft Development">
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
// <author>Денис Козлов</author>
// <email>mailto:deniskozlov@outlook.com</email>
// <date>26.01.2014</date>
// <summary>Summary here....</summary>
namespace aerp.modules.irr.entities.Production
{
	using Classification;
	using entities;

	/// <summary>
	/// Динамическое свойство товара
	/// </summary>
	public class ProductAttribute : EntityBase
    {
		/// <summary>
		/// Идентификатор универсального динамического свойства
		/// </summary>
        public int SubjectAttributeId { get; set; }
		/// <summary>
		/// Универсальное динамическое свойство
		/// </summary>
        public SubjectAttribute SubjectAttribute { get; set; }
    }
}