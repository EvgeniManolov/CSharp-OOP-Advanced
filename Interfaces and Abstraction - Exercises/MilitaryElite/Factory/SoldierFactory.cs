using System;
using System.Collections.Generic;
using MilitaryElite.Interfaces;
using MilitaryElite.Models;

namespace MilitaryElite.Factory
{
    public class SoldierFactory
    {
        private static readonly Dictionary<int, IPrivate> Privates = new Dictionary<int, IPrivate>();

        public static ISoldier ProduceSoldier(string input)
        {
            string[] token = input.Split();

            string soldierType = token[0];
            int soldierId = int.Parse(token[1]);
            string soldierFirstName = token[2];
            string soldierSecondName = token[3];

            switch (soldierType)
            {
                case "Private":
                    Private priv = new Private(soldierId, soldierFirstName, soldierSecondName, double.Parse(token[4]));
                    Privates.Add(soldierId, priv);
                    return priv;
                case "LeutenantGeneral":
                    LeutenantGeneral leutenant = new LeutenantGeneral(
                        soldierId,
                        soldierFirstName,
                        soldierSecondName,
                        double.Parse(token[4]));
                    for (int i = 5; i < token.Length; i++)
                    {
                        int searchedID = int.Parse(token[i]);
                        IPrivate p = Privates[searchedID];
                        leutenant.AddPrivate(p);
                    }

                    Privates.Add(soldierId, leutenant);
                    return leutenant;

                case "Engineer":
                    Engineer engineer = new Engineer(
                        soldierId,
                        soldierFirstName,
                        soldierSecondName,
                        double.Parse(token[4]),
                        token[5]);
                    for (int i = 6; i < token.Length; i += 2)
                    {
                        IRepair repair = new Repair(token[i], int.Parse(token[i + 1]));
                        engineer.AddRepair(repair);
                    }
                    Privates.Add(soldierId, engineer);
                    return engineer;

                case "Commando":
                    Commando commando = new Commando(
                        soldierId,
                        soldierFirstName,
                        soldierSecondName,
                        double.Parse(token[4]),
                        token[5]);
                    for (int i = 6; i < token.Length; i += 2)
                    {
                        string missionName = token[i];
                        string missionState = token[i + 1];

                        try
                        {
                            Mission m = new Mission(missionName, missionState);
                            commando.AddMission(m);
                        }
                        catch (Exception)
                        {
                        }
                    }
                    Privates.Add(soldierId, commando);
                    return commando;

                case "Spy":
                    int soldeirCodeNumber = int.Parse(token[4]);
                    Spy spy = new Spy(soldierId, soldierFirstName, soldierSecondName, soldeirCodeNumber);
                    return spy;

                default: return null;
            }
        }
    }
}