﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Globalization;
using System.Diagnostics;
using OpenTK;
using OpenTKExtension;


namespace ICPLib
{
    public class SettingsICP
    {
        public ICP_VersionUsed ICPVersion = ICP_VersionUsed.Umeyama;
        public bool ChangeColorsOfMergedPoints = true;
        public float ThresholdMergedPoints = Convert.ToSingle(5E-5);
        public float ThresholdConvergence = Convert.ToSingle(1E-5);
        public float ThresholdIgnoreICP = Convert.ToSingle(5E-3);

        public int MaxNumberSolutions = 10;
        public int NumberOfStartTrialPoints = 100000;

        public bool SimulatedAnnealing = false;
        public bool Normal_RemovePoints = false;
        public bool Normal_SortPoints = false;

        public bool FixedTestPoints = false;
        public int MaximumNumberOfIterations = 100;
        public bool ResetVector3ToOrigin = true;
        public bool DistanceOptimization = false;
        
        public bool PerformInitial2DICP = false;
        public bool ShuffleEffect = false;
        public float MaximumMeanDistance;
        public float ThresholdOutlier = 10;
        public bool IgnoreFarPoints;

        public bool Prealign_PCA = false;

        public bool SingleSourceTargetMatching = false;

        public int LogLevel = 0;
        

    }
}
