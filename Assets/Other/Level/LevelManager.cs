﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class LevelManager : MonoBehaviour 
{
    public static List<Level> easyLevels = new List<Level>();
    public static List<Level> mediumLevels = new List<Level>();
    public static List<Level> hardLevels = new List<Level>();


    public static void Save()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Level>));

        //Save easy levels
        using (FileStream stream = new FileStream("D:/levelsEasy.xml", FileMode.Create)) serializer.Serialize(stream, easyLevels);

        //Save medium levels
        using (FileStream stream = new FileStream("D:/levelsMedium.xml", FileMode.Create)) serializer.Serialize(stream, mediumLevels);

        //Save hard levels
        using (FileStream stream = new FileStream("D:/levelsHard.xml", FileMode.Create)) serializer.Serialize(stream, hardLevels);
    }

    public static void Load()
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Level>));

        //Load easy levels
        using (FileStream stream = new FileStream("D:/levelsEasy.xml", FileMode.Open)) easyLevels = (List<Level>)serializer.Deserialize(stream);

        //Load medium levels
        using (FileStream stream = new FileStream("D:/levelsMedium.xml", FileMode.Open)) mediumLevels = (List<Level>)serializer.Deserialize(stream);

        //Load hard levels
        using (FileStream stream = new FileStream("D:/levelsHard.xml", FileMode.Open)) hardLevels = (List<Level>)serializer.Deserialize(stream);
    }



	void Start () 
    {
       /* mediumLevels.Add(new Level());


        mediumLevels[0].bestMoves = 10;
        mediumLevels[0].bestTime = 600F;

        for (int i = 0; i < 81; ++i)
        {
            mediumLevels[0].arena[i].display = true;
            mediumLevels[0].arena[i].value = i + 15;
        }



        easyLevels.Add(new Level());

        easyLevels[0].bestMoves = 1;
        easyLevels[0].bestTime = 125F;
        
        for(int i = 0; i < 81; ++i)
        {
            easyLevels[0].arena[i].display = true;
            easyLevels[0].arena[i].value = 1;
        }

        easyLevels[0].arena[20].display = false;

        easyLevels.Add(new Level());

        easyLevels[1].bestMoves = 2;
        easyLevels[1].bestTime = 225F;

        for (int i = 0; i < 81; ++i)
        {
            easyLevels[1].arena[i].display = true;
            easyLevels[1].arena[i].value = i + 5;
        }*/

        //Save();
	}
}
