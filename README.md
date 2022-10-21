# PointClouds
Utils for PointClouds

## Notes
This is a conversion to net core 6 apps, and more up-to-date Nuget packages (installed via paket, run `dotnet tool restore` to get it).

What doesn't work:

- [ ] The unit tests (mostly appears to be GLFW wanting the UI thread, and missing test data files)
- [ ] The Kinect apps (the Kinect runtime installs in the .net framwork GAC, and .net Core can't find it)
- [ ] RealSenseBO (the project looks to have been using a custom build of AForge with support for a VideoSourceType of Depth)
