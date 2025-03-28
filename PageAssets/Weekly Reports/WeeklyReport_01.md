# The Guild - Gameplay Loop Team 1 Weekly Report

## Week Overview

This week marks the commencement of our development work on the Combat System for The Guild. Based on our previous discussions, we've decided to build upon the existing Turn-Based JRPG Template asset, enhancing it to align with our target combat system specifications.

## Analysis of Current Template and Requirements

After carefully reviewing the template documentation and comparing it with the game design document (GDD) and Andy's game specifications, we've identified several key areas that need enhancement to transform the current system into a Darkest Dungeon-style combat system suitable for The Guild:

### Position System
This element forms one of the foundational mechanics of our combat system. Many other systems will interact with it, influencing player choices and adding strategic depth to battles.

Requirements:
- Units should deploy in an 8-position formation (4 positions for allies on left, 4 for enemies on right)
- Units within the same team should be able to swap positions
- Various actions should integrate with the position system (skill targeting, activation conditions, etc.)

### Stress Value
Allied characters will have a "Stress" attribute that can be read and modified externally. When stress falls below certain thresholds, character actions will be affected, adding another layer of management for players.

### Randomized Value Calculations
To enhance gameplay unpredictability, attributes such as critical hit rates, accuracy, dodge chance, speed, and attack power will fluctuate within defined ranges during actual application.

### Near-Death State
When a player character's HP drops to zero, they enter a near-death state. Additional damage will trigger probability-based death checks rather than immediate elimination.

### Skills
The system requires a more diverse range of abilities for units to utilize in combat.

### Status Effects
Implementation of various status effects including poison, bleeding, blindness, stun, fear, and others.

### Visual Enhancements and User Experience
- Model and animation replacements based on unit character designs
- More aesthetically pleasing and functional UI
- Enhanced visual effects for combat actions

We believe that implementing these features will bring our combat system to a mature state, ready for integration with other modules.

## Task Allocation and Progress

Based on the analysis above, we've distributed tasks among our team members and made significant progress in the first week.

| **Feature**                         | **Description**                                                                                           | **Assigned To**                         |
|------------------------------------|-----------------------------------------------------------------------------------------------------------|-----------------------------------------|
| Positioning System                 | Units have fixed slots for deployment, can swap positions, and skill effects depend on position.         | Xu Hongjun, Lin Baizhen                 |
| Stress System                      | Allied characters have a "stress value" affecting their actions when it drops below a threshold.         | Ji Qi                                   |
| Random Probability Fluctuation     | Critical rate, hit rate, dodge rate, and speed will have a range of fluctuations for randomness.         | Ji Qi                                   |
| Near-Death State                   | Characters enter a near-death state at 0 HP, with probability-based checks for survival upon damage.     | Tang Yingxuan                           |
| Character Expansion & Animation    | Adapting character models, animations, and skills to fit their design.                                   | Zhang Jin                               |
| Skill Expansion                    | Designing additional skills with various effects for heroes.                                              | Xing Chen                            |
| Buff & Debuff Expansion            | Designing various buffs and debuffs such as poison, bleeding, blindness, fear, etc.                      | Shuqi Zhuang                               |


### Completed Implementations

1. **Basic Position System**
   - Successfully implemented unit deployment in the 8-position formation
   
   ![Position System Deployment](https://i.imgur.com/DkHugYl.gif)

2. **Position Swapping Logic**
   - Units within the same team can now exchange positions
   
   ![Position Swapping](https://i.imgur.com/yeRKmZG.gif)

3. **Range-Limited Actions**
   - Units now have limited reach and cannot target units outside their attack range
   
   ![Range Limitation](https://i.imgur.com/QklBJEW.gif)

4. **Stress Value Attribute**
   - Added stress as a core character attribute with external interfaces for modification

5. **Random Fluctuation Calculation Interface**
   - Implemented the backend framework for randomized attribute calculations

6. **New Skills**
   - Developed 5 entirely new skills for combat units, below are two examples
   - Shield Bash: deal damage and push enemy back 1-2 position
   
   ![Shield Bash](https://i.imgur.com/68C3XaF.gif)

   - Scorching Strike: deal damage and apply burning debuff
   
   ![Scorching Strike](https://i.imgur.com/CwDq43r.gif)

### Pending Implementations (Current Sprint)

1. **Stress Threshold Effects**
   - Implementing specific consequences when stress falls below threshold values

2. **Practical Application of Random Fluctuations**
   - Integrating the randomized calculation system with combat mechanics

3. **Near-Death State Mechanics**
   - Implementing the near-death state and associated probability checks

4. **Status Effects**
   - Developing 4 different types of status effects/buffs

We expect to complete these remaining items within the current sprint. Visual enhancements and UI improvements are planned for subsequent phases, as they build upon the core mechanical foundation we're establishing now.

## Next Steps

- Complete the pending implementations listed above
- Begin planning for the visual enhancement phase
- Prepare for preliminary integration testing with other systems
- Set up regular review meetings with Team 2 to ensure compatibility

## Conclusion

We're making steady progress toward our goal of creating a strategic, position-based combat system inspired by Darkest Dungeon. The foundational elements are taking shape, and we're on track to deliver all core combat mechanics within the planned timeframe.
