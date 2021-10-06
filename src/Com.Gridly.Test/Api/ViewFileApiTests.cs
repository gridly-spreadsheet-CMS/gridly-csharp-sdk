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
    ///  Class for testing ViewFileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ViewFileApiTests
    {
        private ViewFileApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ViewFileApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ViewFileApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ViewFileApi
            //Assert.IsInstanceOf(typeof(ViewFileApi), instance);
        }

        
        /// <summary>
        /// Test Download
        /// </summary>
        [Test]
        public void DownloadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //string viewId = null;
            //var response = instance.Download(fileId, viewId);
            //Assert.IsInstanceOf(typeof(Object), response, "response is Object");
        }
        
        /// <summary>
        /// Test Upload
        /// </summary>
        [Test]
        public void UploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //Object columnId = null;
            //System.IO.Stream file = null;
            //Object recordId = null;
            //var response = instance.Upload(viewId, columnId, file, recordId);
            //Assert.IsInstanceOf(typeof(UploadedFile), response, "response is UploadedFile");
        }
        
        /// <summary>
        /// Test UploadZip
        /// </summary>
        [Test]
        public void UploadZipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //Object columnId = null;
            //Object file = null;
            //var response = instance.UploadZip(viewId, columnId, file);
            //Assert.IsInstanceOf(typeof(List<Record>), response, "response is List<Record>");
        }
        
    }

}
