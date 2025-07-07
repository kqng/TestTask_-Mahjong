using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Level
{
    [Serializable]
    public class LevelData 
    {
        public int level;
        public List<LevelInfo> data;
    }
    [Serializable]
    public class LevelInfo
    {
        public int floor;
        public List<LevelTiles> rows;
    }
    [Serializable]
    public class LevelTiles
    {
        public List<int> tiles;
    }
}
