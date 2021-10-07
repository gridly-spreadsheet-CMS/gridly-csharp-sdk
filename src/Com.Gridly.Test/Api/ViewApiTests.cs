/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.13.0-SNAPSHOT
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Com.Gridly.Client;
using Com.Gridly.Api;
using Com.Gridly.Model;

namespace Com.Gridly.Test
{
    /// <summary>
    ///  Class for testing ViewApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ViewApiTests
    {
        private ViewApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ViewApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ViewApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ViewApi
            //Assert.IsInstanceOf(typeof(ViewApi), instance);
        }

        
        /// <summary>
        /// Test Export
        /// </summary>
        [Test]
        public void ExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //List<string> columnIds = null;
            //string query = null;
            //string sort = null;
            //string type = null;
            //var response = instance.Export(viewId, columnIds, query, sort, type);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //List<string> columnIds = null;
            //List<string> include = null;
            //string page = null;
            //string query = null;
            //string sort = null;
            //var response = instance.Get(viewId, columnIds, include, page, query, sort);
            //Assert.IsInstanceOf(typeof(View), response, "response is View");
        }
        
        /// <summary>
        /// Test ImportView
        /// </summary>
        [Test]
        public void ImportViewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //System.IO.Stream file = null;
            //Object importRequest = null;
            //Object type = null;
            //instance.ImportView(viewId, file, importRequest, type);
            
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string branchId = null;
            //string gridId = null;
            //string type = null;
            //var response = instance.List(branchId, gridId, type);
            //Assert.IsInstanceOf(typeof(List<View>), response, "response is List<View>");
        }
        
    }

}