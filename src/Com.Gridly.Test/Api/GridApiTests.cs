/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.23.2
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
    ///  Class for testing GridApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GridApiTests
    {
        private GridApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GridApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GridApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' GridApi
            //Assert.IsInstanceOf(typeof(GridApi), instance);
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //CreateGrid createGrid = null;
            //var response = instance.Create(dbId, createGrid);
            //Assert.IsInstanceOf(typeof(Grid), response, "response is Grid");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gridId = null;
            //instance.Delete(gridId);
            
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gridId = null;
            //var response = instance.Get(gridId);
            //Assert.IsInstanceOf(typeof(Grid), response, "response is Grid");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //var response = instance.List(dbId);
            //Assert.IsInstanceOf(typeof(List<Grid>), response, "response is List<Grid>");
        }
        
        /// <summary>
        /// Test ListTemplateGrids
        /// </summary>
        [Test]
        public void ListTemplateGridsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListTemplateGrids();
            //Assert.IsInstanceOf(typeof(List<Grid>), response, "response is List<Grid>");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gridId = null;
            //UpdateGrid updateGrid = null;
            //var response = instance.Update(gridId, updateGrid);
            //Assert.IsInstanceOf(typeof(Grid), response, "response is Grid");
        }
        
    }

}
