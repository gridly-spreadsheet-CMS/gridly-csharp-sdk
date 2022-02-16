/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.21.3
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
    ///  Class for testing ProjectApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectApiTests
    {
        private ProjectApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProjectApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProjectApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' ProjectApi
            //Assert.IsInstanceOf(typeof(ProjectApi), instance);
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateProject createProject = null;
            //var response = instance.Create(createProject);
            //Assert.IsInstanceOf(typeof(Project), response, "response is Project");
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long projectId = null;
            //instance.Delete(projectId);
            
        }
        
        /// <summary>
        /// Test FindOne
        /// </summary>
        [Test]
        public void FindOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long projectId = null;
            //var response = instance.FindOne(projectId);
            //Assert.IsInstanceOf(typeof(ProjectDetail), response, "response is ProjectDetail");
        }
        
        /// <summary>
        /// Test List
        /// </summary>
        [Test]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.List();
            //Assert.IsInstanceOf(typeof(List<Project>), response, "response is List<Project>");
        }
        
        /// <summary>
        /// Test Update
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long projectId = null;
            //UpdateProject updateProject = null;
            //var response = instance.Update(projectId, updateProject);
            //Assert.IsInstanceOf(typeof(Project), response, "response is Project");
        }
        
    }

}
