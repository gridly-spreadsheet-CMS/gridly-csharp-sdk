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
    ///  Class for testing TaskApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TaskApiTests
    {
        private TaskApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TaskApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TaskApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' TaskApi
            //Assert.IsInstanceOf(typeof(TaskApi), instance);
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //var response = instance.Get(taskId);
            //Assert.IsInstanceOf(typeof(Task), response, "response is Task");
        }
        
    }

}