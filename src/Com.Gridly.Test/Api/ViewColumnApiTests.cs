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
    ///  Class for testing ViewColumnApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ViewColumnApiTests
    {
        private ViewColumnApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ViewColumnApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ViewColumnApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ViewColumnApi
            //Assert.IsInstanceOf(typeof(ViewColumnApi), instance);
        }

        
        /// <summary>
        /// Test Add
        /// </summary>
        [Test]
        public void AddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //var response = instance.Add(columnId, viewId);
            //Assert.IsInstanceOf(typeof(ViewColumn), response, "response is ViewColumn");
        }
        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //CreateColumn createColumn = null;
            //var response = instance.Create(viewId, createColumn);
            //Assert.IsInstanceOf(typeof(ViewColumn), response, "response is ViewColumn");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //instance.Delete(columnId, viewId);
            
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //var response = instance.Get(columnId, viewId);
            //Assert.IsInstanceOf(typeof(ViewColumn), response, "response is ViewColumn");
        }
        
        /// <summary>
        /// Test Remove
        /// </summary>
        [Test]
        public void RemoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //instance.Remove(columnId, viewId);
            
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //UpdateColumn updateColumn = null;
            //var response = instance.Update(columnId, viewId, updateColumn);
            //Assert.IsInstanceOf(typeof(ViewColumn), response, "response is ViewColumn");
        }
        
    }

}
