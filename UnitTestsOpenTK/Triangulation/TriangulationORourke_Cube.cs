﻿using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

using OpenTKExtension;
using OpenTK;


using System.Linq;
using OpenTK.Mathematics;

namespace UnitTestsOpenTK.Triangulation
{
    [TestFixture]
    [Category("UnitTest")]
    public class TriangulationORourke_Cube : TestBase
    {

    
         [Test]
         public void Cube_Delaunay_RandomPoints()
         {
            
             pointCloudSource = PointCloud.CreateCube_Corners_CenteredAt0(2);
             
             PointCloud.SetColorOfListTo(pointCloudSource, Color.Red);
             List<Vector3> myListVectors = pointCloudSource.ListVectors;

             DelaunayTri delaunay = new DelaunayTri(myListVectors);



            ShowPointCloud(pointCloudSource);


        }
         [Test]
         public void Cube_DelaunayOLD_RandomPoints()
         {
             
             pointCloudSource = PointCloud.CreateCube_Corners_CenteredAt0(2);

             //pointCloud = Vertices.CreateCube_Corners(0.1);
             PointCloud.SetColorOfListTo(pointCloudSource, Color.Red);
             List<Vector3> myListVectors = pointCloudSource.ListVectors;

             DelaunayTri_Old delaunay = new DelaunayTri_Old(myListVectors);



            ShowPointCloud(pointCloudSource);


        }
         [Test]
         public void Cube_Voronoi_RandomPoints()
         {
             pointCloudSource = PointCloud.CreateCube_RandomPointsOnPlanes(1, 10);

             //pointCloud = Vertices.CreateCube_Corners(0.1);
             PointCloud.SetColorOfListTo(pointCloudSource, Color.Red);
             List<Vector3> myListVectors = pointCloudSource.ListVectors;

             DelaunayTri delaunay = new DelaunayTri();
             delaunay.Voronoi(myListVectors);



            ShowPointCloud(pointCloudSource);


        }
    
    }
}
