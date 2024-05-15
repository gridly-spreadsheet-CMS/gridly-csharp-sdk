/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.33.0
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
    ///  Class for testing PathApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PathApiTests
    {
        private PathApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PathApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PathApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' PathApi
            //Assert.IsInstanceOf(typeof(PathApi), instance);
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //CreatePath createPath = null;
            //var response = instance.Create(viewId, createPath);
            //Assert.IsInstanceOf(typeof(PathList), response, "response is PathList");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //DeletePath deletePath = null;
            //instance.Delete(viewId, deletePath);
            
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //string rootPath = null;
            //var response = instance.List(viewId, rootPath);
            //Assert.IsInstanceOf(typeof(List<PathNode>), response, "response is List<PathNode>");
        }
        
        /// <summary>
        /// Test Move
        /// </summary>
        [Test]
        public void MoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //MovePath movePath = null;
            //var response = instance.Move(viewId, movePath);
            //Assert.IsInstanceOf(typeof(PathList), response, "response is PathList");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //string path = null;
            //UpdatePath updatePath = null;
            //var response = instance.Update(viewId, path, updatePath);
            //Assert.IsInstanceOf(typeof(PathSingle), response, "response is PathSingle");
        }
        
    }

}
