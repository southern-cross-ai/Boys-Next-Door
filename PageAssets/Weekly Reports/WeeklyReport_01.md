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

### Completed Implementations

1. **Basic Position System**
   - Successfully implemented unit deployment in the 8-position formation
   <figure>
  <img src="https://i.imgur.com/Nn6jxI8.gif" alt="Position System Deployment">
  <figcaption style="text-align: center;">Position System Deployment</figcaption>
   </figure>


2. **Position Swapping Logic**
   - Units within the same team can now exchange positions
   <figure>
  <img src="https://i.imgur.com/G1AwbmZ.gif" alt="Position System Deployment">
  <figcaption style="text-align: center;">Position Swapping</figcaption>
   </figure>

3. **Range-Limited Actions**
   - Units now have limited reach and cannot target units outside their attack range
   <figure>
  <img src="https://i.imgur.com/JMweX4h.gif" alt="Range Limitation">
  <figcaption style="text-align: center;">Range Limitation</figcaption>
   </figure>

4. **Stress Value Attribute**
   - Added stress as a core character attribute with external interfaces for modification

5. **Random Fluctuation Calculation Interface**
   - Implemented the backend framework for randomized attribute calculations


6. **New Skills**
   - Developed 5 entirely new skills for combat units
   - Shield Bash: deal damage and push enemy back 1-2 position
   <figure>
  <img src="https://i.imgur.com/3s3PmnD.gif" alt="Range Limitation">
  <figcaption style="text-align: center;">Shield Bash</figcaption>
   </figure>
   - Scorching Strike: deal damage and apply burning debuff
   <figure>
  <img src="https://i.imgur.com/eZ9RNHy.gif" alt="Range Limitation">
  <figcaption style="text-align: center;">Scorching Strike</figcaption>
   </figure>

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