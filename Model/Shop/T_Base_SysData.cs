﻿/**  版本信息模板在安装目录下，可自行修改。
* T_Base_SysData.cs
*
* 功 能： N/A
* 类 名： T_Base_SysData
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/8/1 11:47:59   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace SoulShop.Model
{
	/// <summary>
	/// T_Base_SysData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Base_SysData
	{
		public T_Base_SysData()
		{}
		#region Model
		private int? _saleproductsum;
		private int? _freezeadminordernumber;
		private int? _sumsaleproductsum;
		/// <summary>
		/// 
		/// </summary>
		public int? SaleProductSum
		{
			set{ _saleproductsum=value;}
			get{return _saleproductsum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FreezeAdminOrderNumber
		{
			set{ _freezeadminordernumber=value;}
			get{return _freezeadminordernumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SumSaleProductSum
		{
			set{ _sumsaleproductsum=value;}
			get{return _sumsaleproductsum;}
		}
		#endregion Model

	}
}

