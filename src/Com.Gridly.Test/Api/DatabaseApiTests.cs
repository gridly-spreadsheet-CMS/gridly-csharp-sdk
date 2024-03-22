/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.29.1
 * Contact: support@gridly.com
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
    ///  Class for testing DatabaseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DatabaseApiTests
    {
        private DatabaseApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DatabaseApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DatabaseApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' DatabaseApi
            //Assert.IsInstanceOf(typeof(DatabaseApi), instance);
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long projectId = null;
            //CreateDatabase body = null;
            //var response = instance.Create(projectId, body);
            //Assert.IsInstanceOf(typeof(Database), response, "response is Database");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //instance.Delete(dbId);
            
        }
        
        /// <summary>
        /// Test Duplicate
        /// </summary>
        [Test]
        public void DuplicateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //long projectId = null;
            //CreateDatabase body = null;
            //var response = instance.Duplicate(dbId, projectId, body);
            //Assert.IsInstanceOf(typeof(Database), response, "response is Database");
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //var response = instance.Get(dbId);
            //Assert.IsInstanceOf(typeof(Database), response, "response is Database");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> expand = null;
            //string page = null;
            //long? projectId = null;
            //string search = null;
            //string sort = null;
            //var response = instance.List(expand, page, projectId, search, sort);
            //Assert.IsInstanceOf(typeof(List<Database>), response, "response is List<Database>");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //UpdateDatabase body = null;
            //var response = instance.Update(dbId, body);
            //Assert.IsInstanceOf(typeof(Database), response, "response is Database");
        }
        
    }

}
