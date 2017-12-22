﻿using wServer.logic.behaviors;
using wServer.logic.loot;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        _ CubeGod = () => Behav()
            .Init("Cube God",
                new State(
                    new StayCloseToSpawn(0.3, range: 7),
                           new Wander(0.5),
                             new Shoot(10, count: 9, predictive: 0.9, shootAngle: 6.5, coolDown: 1000),
                             new Spawn("Cube Overseer", maxChildren: 5, initialSpawn: 3, coolDown: 100000),
                             new Spawn("Cube Defender", maxChildren: 5, initialSpawn: 5, coolDown: 100000),
                             new Spawn("Cube Blaster", maxChildren: 5, initialSpawn: 5, coolDown: 100000)
                ),
                new Threshold(1.0,
                    new TierLoot(3, ItemType.Ring, 1),
                    new TierLoot(7, ItemType.Armor, 1),
                    new TierLoot(8, ItemType.Weapon, 1),
                    new TierLoot(4, ItemType.Ability, 1),
                    new TierLoot(8, ItemType.Armor, 1),
                    new TierLoot(4, ItemType.Ring, 1),
                    new TierLoot(9, ItemType.Armor, 1),
                    new TierLoot(5, ItemType.Ability, 1),
                    new TierLoot(9, ItemType.Weapon, 1),
                    new TierLoot(10, ItemType.Armor, 1),
                    new TierLoot(10, ItemType.Weapon, 1),
                    new TierLoot(11, ItemType.Armor, 1),
                    new TierLoot(11, ItemType.Weapon, 1),
                    new TierLoot(5, ItemType.Ring, 1),
                    new ItemLoot("Dirk of Cronus", 1),
                    new ItemLoot("Potion of Dexterity", 1),
                    new ItemLoot("Potion of Attack", 1)
                )
            )
            .Init("Cube Overseer",
                new State(
                    new StayCloseToSpawn(0.3, range: 7),
                             new Wander(1),
                             new Shoot(10, count: 4, predictive: 0.9, projectileIndex: 0, coolDown: 1250)
                )
            )
            .Init("Cube Defender",
                new State(
                    new Wander(0.5),
                             new StayCloseToSpawn(0.03, range: 7),
                             new Follow(0.4, acquireRange: 9, range: 2),
                             new Shoot(10, count: 1, coolDown: 1000, predictive: 0.9, projectileIndex: 0)
                )
            )
            .Init("Cube Blaster",
                new State(
                    new Wander(0.5),
                             new StayCloseToSpawn(0.03, range: 7),
                             new Follow(0.4, acquireRange: 9, range: 2),
                             new Shoot(10, count: 2, predictive: 0.9, projectileIndex: 0, coolDown: 1500),
                             new Shoot(10, count: 1, predictive: 0.9, projectileIndex: 0, coolDown: 1500)
                )
            );
    }
}
