﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	ErrorLogSqlBusiness.cs
//
// summary:	Implements the error log SQL business class
////////////////////////////////////////////////////////////////////////////////////////////////////
namespace ErrorLog.Business.Sql
{
    using SqlDb;
    using System.Configuration;

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An error log SQL business. </summary>
    ///
    /// <remarks>   Mustafa SAÇLI, 26.04.2019. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    public class ErrorLogSqlBusiness : ErrorLogBaseSqlBusiness
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Mustafa SAÇLI, 26.04.2019. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        public ErrorLogSqlBusiness()
            : base(
                  ConfigurationManager.AppSettings["errorLogConnName"],
                  ConfigurationManager.ConnectionStrings[ConfigurationManager.AppSettings["errorLogConnStringName"]].ConnectionString)
        { }
    }
}