/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 5.9.0
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
    ///  Class for testing BranchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BranchApiTests
    {
        private BranchApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BranchApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BranchApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' BranchApi
            //Assert.IsInstanceOf(typeof(BranchApi), instance);
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBranch createBranch = null;
            //string gridId = null;
            //string branchId = null;
            //var response = instance.Create(createBranch, gridId, branchId);
            //Assert.IsInstanceOf(typeof(Branch), response, "response is Branch");
        }
        
        /// <summary>
        /// Test CreateDiffCheck
        /// </summary>
        [Test]
        public void CreateDiffCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sourceViewId = null;
            //string destinationViewId = null;
            //var response = instance.CreateDiffCheck(sourceViewId, destinationViewId);
            //Assert.IsInstanceOf(typeof(Task), response, "response is Task");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string branchId = null;
            //instance.Delete(branchId);
            
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string branchId = null;
            //var response = instance.Get(branchId);
            //Assert.IsInstanceOf(typeof(Branch), response, "response is Branch");
        }
        
        /// <summary>
        /// Test GetDiffCheck
        /// </summary>
        [Test]
        public void GetDiffCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //List<string> mergeRecordOptions = null;
            //string query = null;
            //string page = null;
            //var response = instance.GetDiffCheck(taskId, mergeRecordOptions, query, page);
            //Assert.IsInstanceOf(typeof(List<BranchDiffRecord>), response, "response is List<BranchDiffRecord>");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gridId = null;
            //var response = instance.List(gridId);
            //Assert.IsInstanceOf(typeof(List<Branch>), response, "response is List<Branch>");
        }
        
        /// <summary>
        /// Test Merge
        /// </summary>
        [Test]
        public void MergeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string branchId = null;
            //string destinationBranchId = null;
            //MergeBranchRequest mergeBranchRequest = null;
            //List<string> mergeRecordOptions = null;
            //var response = instance.Merge(branchId, destinationBranchId, mergeBranchRequest, mergeRecordOptions);
            //Assert.IsInstanceOf(typeof(Task), response, "response is Task");
        }
        
    }

}
