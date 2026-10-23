using System;
using System.Collections.Generic;
using CommandSystem.Commands;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Server;
using Exiled.API.Enums;
using Exiled.API.Extensions;
using MEC;
using Exiled.CustomRoles.API.Features;

namespace NanoRoles.Handlers.Serwer
{
    public class RespawnedTeamH
    {
        public static void RespawnedTeam(RespawningTeamEventArgs ar)
        {
            Plugin pl = Plugin.pl;


            List<Player> spawningPlayers = new List<Player>(ar.Players);
            if (spawningPlayers.Count == 0)
                return;

            ar.Players.Clear();

            if (ar.NextKnownTeam == PlayerRoles.Faction.FoundationStaff)
            {

                SpawnNTF(spawningPlayers);
            }

            if (ar.NextKnownTeam == PlayerRoles.Faction.FoundationEnemy)
                SpawnChaos(spawningPlayers);
        }

        public static void SpawnNTF(List<Player> players)
        {
            Plugin pl = Plugin.pl;

            if (pl.NtfWawes == 0)
            {
                int CapIndex = UnityEngine.Random.Range(0, players.Count);
                pl.kapitanGBR.AddRole(players[CapIndex]);
                players.Remove(players[CapIndex]);

                if (players.Count <= 3)
                {
                    int MedicIndex = UnityEngine.Random.Range(0, players.Count);
                    pl.medicGBR.AddRole(players[MedicIndex]);
                    players.Remove(players[MedicIndex]);
                }
                else
                {
                    int MedicIndex = UnityEngine.Random.Range(0, players.Count);
                    pl.medicGBR.AddRole(players[MedicIndex]);
                    players.Remove(players[MedicIndex]);

                    int MedicIndex1 = UnityEngine.Random.Range(0, players.Count);
                    pl.medicGBR.AddRole(players[MedicIndex1]);
                    players.Remove(players[MedicIndex1]);
                }

                foreach (Player player in players)
                {
                    pl.operGBR.AddRole(player);
                }
                players.Clear();
                pl.NtfWawes += 1;

                Exiled.API.Features.Cassie.Clear();
                Exiled.API.Features.Cassie.Message(pl.Config.GbrCassieText);

                Timing.CallDelayed(1.2f, () =>
                Exiled.API.Features.Cassie.Clear());
            }

            else
            {
                int totalPlayers = players.Count;

                // Рассчитываем количество Капитанов и Сержантов (по 1 на каждые 5 игроков)
                int leadersCount = totalPlayers / 5;

                // Защита: если игроков мало, делаем минимум 1 Капитана и 1 Сержанта
                if (leadersCount == 0 && totalPlayers >= 2)
                {
                    leadersCount = 1;
                }

                List<Player> captains = new List<Player>();
                List<Player> sergeants = new List<Player>();
                List<Player> remainingPlayers = new List<Player>();

                // 1. Цикл FOR: Выбираем Капитанов
                for (int i = 0; i < leadersCount; i++)
                {
                    if (players.Count == 0) break;
                    int index = UnityEngine.Random.Range(0, players.Count);
                    captains.Add(players[index]);
                    players.RemoveAt(index);
                }

                // 2. Цикл FOR: Выбираем Сержантов
                for (int i = 0; i < leadersCount; i++)
                {
                    if (players.Count == 0) break;
                    int index = UnityEngine.Random.Range(0, players.Count);
                    sergeants.Add(players[index]);
                    players.RemoveAt(index);
                }

                // 3. Цикл FOR: Все остальные идут в общий пул для Рядовых и Медиков
                for (int i = 0; i < players.Count; i++)
                {
                    remainingPlayers.Add(players[i]);
                }
                players.Clear();

                // 4. Цикл FOR: Выдаем роли Капитанам
                for (int i = 0; i < captains.Count; i++)
                {
                    pl.capitanE11.AddRole(captains[i]);
                }

                // 5. Цикл FOR: Выдаем роли Сержантам
                for (int i = 0; i < sergeants.Count; i++)
                {
                    // Замените pl.sergeantE11 на ваше реальное поле сержанта, если оно называется иначе
                    pl.scherjantE11.AddRole(sergeants[i]);
                }

                // 6. Цикл FOR: Случайно распределяем оставшихся на Рядовых и Медиков (50 на 50)
                int remainingCount = remainingPlayers.Count;
                for (int i = 0; i < remainingCount; i++)
                {
                    // Выбираем случайного игрока из оставшихся
                    int index = UnityEngine.Random.Range(0, remainingPlayers.Count);
                    Player luckyPlayer = remainingPlayers[index];
                    remainingPlayers.RemoveAt(index);

                    // Рандомно решаем: Рядовой или Медик
                    if (UnityEngine.Random.Range(0, 2) == 0)
                    {
                        pl.privateE11.AddRole(luckyPlayer);
                    }
                    else
                    {
                        // Замените pl.medicE11 на ваше реальное поле медика E11
                        pl.medicE11.AddRole(luckyPlayer);
                    }
                }

                // Увеличиваем счетчик волн МОГ
                pl.NtfWawes += 1;
            }
        }

        public static void SpawnChaos(List<Player> players)
        {
            Plugin pl = Plugin.pl;

            int totalPlayers = players.Count;

            // Рассчитываем количество Капитанов и Сержантов (по 1 на каждые 5 игроков)
            int leadersCount = totalPlayers / 5;

            // Защита: если игроков мало, делаем минимум 1 Капитана и 1 Сержанта
            if (leadersCount == 0 && totalPlayers >= 2)
            {
                leadersCount = 1;
            }

            List<Player> gamma = new List<Player>();
            List<Player> beta = new List<Player>();
            List<Player> alfa = new List<Player>();

            // 1. Цикл FOR: Выбираем Капитанов
            for (int i = 0; i < leadersCount; i++)
            {
                if (players.Count == 0) break;
                int index = UnityEngine.Random.Range(0, players.Count);
                gamma.Add(players[index]);
                players.RemoveAt(index);
            }

            // 2. Цикл FOR: Выбираем Сержантов
            for (int i = 0; i < leadersCount; i++)
            {
                if (players.Count == 0) break;
                int index = UnityEngine.Random.Range(0, players.Count);
                beta.Add(players[index]);
                players.RemoveAt(index);
            }

            // 3. Цикл FOR: Все остальные идут в общий пул для Рядовых и Медиков
            for (int i = 0; i < players.Count; i++)
            {
                alfa.Add(players[i]);
            }
            players.Clear();

            // 4. Цикл FOR: Выдаем роли Капитанам
            for (int i = 0; i < gamma.Count; i++)
            {
                pl.gammaCI.AddRole(gamma[i]);
            }

            // 5. Цикл FOR: Выдаем роли Сержантам
            int remainingCount1 = beta.Count;
            for (int i = 0; i < remainingCount1; i++)
            {
                // Замените pl.sergeantE11 на ваше реальное поле сержанта, если оно называется иначе
                int index = UnityEngine.Random.Range(0, alfa.Count);
                Player luckyPlayer = alfa[index];
                alfa.RemoveAt(index);

                // Рандомно решаем: Рядовой или Медик
                if (UnityEngine.Random.Range(0, 100) >= 60)
                {
                    pl.betaCI.AddRole(luckyPlayer);
                }
                else
                {
                    // Замените pl.medicE11 на ваше реальное поле медика E11
                    pl.medicCI.AddRole(luckyPlayer);
                }
            }

            // 6. Цикл FOR: Случайно распределяем оставшихся на Рядовых и Медиков (50 на 50)
            int remainingCount = alfa.Count;
            for (int i = 0; i < remainingCount; i++)
            {
                // Выбираем случайного игрока из оставшихся
                int index = UnityEngine.Random.Range(0, alfa.Count);
                Player luckyPlayer = alfa[index];
                alfa.RemoveAt(index);

                // Рандомно решаем: Рядовой или Медик
                if (UnityEngine.Random.Range(0, 2) == 0)
                {
                    pl.alfaCI.AddRole(luckyPlayer);
                }
                else
                {
                    // Замените pl.medicE11 на ваше реальное поле медика E11
                    pl.shturmCI.AddRole(luckyPlayer);
                }
            }
        }
    }
}
