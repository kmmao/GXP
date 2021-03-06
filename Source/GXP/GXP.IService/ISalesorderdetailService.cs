﻿/*----------------------------------------------------------------
//
// Copyright (C) 2013 
// 
//
// 文件名：ISalesorderdetailService
// 文件功能描述：
//
// 创建标识：JerryXi 2013/8/20  
//
// 修改标识：
// 修改描述：
// 
//----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Data;
using GXP.DataEntity;

namespace GXP.IService
{
    public interface ISalesorderdetailService
    {
        #region 基本方法
        /// <summary>
        /// 得到所有的Salesorderdetail记录
        /// </summary>
        /// <returns>所有的Salesorderdetail记录</returns>
        DataSet GetAllSalesorderdetail();

        /// <summary>
        /// 根据查询条件得到Salesorderdetail记录
        /// </summary>
        /// <param name="sqlWhere">查询条件集合</param>
        /// <param name="SalesorderdetailQueryEntity">Salesorderdetail查询实体类</param>
        /// <returns>根据查询条件得到Salesorderdetail记录</returns>
        DataSet GetSalesorderdetailByQueryList(QueryEntity salesorderdetailQuery);

        /// <summary>
        /// 根据salesorderdetailID得到一条Salesorderdetail记录
        /// </summary>
        /// <param name="salesorderdetailID">salesorderdetailID</param>
        /// <returns>根据salesorderdetailID得到一条Salesorderdetail记录</returns>
        SalesorderdetailInfo GetSalesorderdetailByID(string salesorderdetailID);

        /// <summary>
        /// 新增一条Salesorderdetail记录
        /// </summary>
        /// <param name="salesorderdetail">Salesorderdetail对象</param>
        /// <returns>执行新增对数据库影响的行数</returns>
        int InsertSalesorderdetail(SalesorderdetailInfo salesorderdetailInfo);

        /// <summary>
        /// 更新一条Salesorderdetail记录
        /// </summary>
        /// <param name="salesorderdetail">Salesorderdetail对象</param>
        /// <returns>执行更新对数据库影响的行数</returns>
        int UpdateSalesorderdetail(SalesorderdetailInfo salesorderdetailInfo);

        /// <summary>
        /// 删除一条Salesorderdetail记录
        /// </summary>
        /// <param name="salesorderdetailID">salesorderdetailID</param>
        /// <returns>执行删除对数据库影响的行数</returns>
        int DeleteSalesorderdetail(List<string> salesorderdetailID);

        /// <summary>
        /// 检查SalesorderdetailID是否已存在
        /// </summary>
        /// <param name="salesorderdetailID">salesorderdetailID</param>
        /// <returns>True:存在  False:不存在</returns>
        bool CheckSalesorderdetailIDIsExist(string salesorderdetailID);
        #endregion

        #region 扩展方法
        #endregion
    }
}
