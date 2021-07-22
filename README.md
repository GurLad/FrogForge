# Frog Forge
A work-in-progress game editor for [Frogman Gaiden](../../../FrogmanGaiden). Both the editor & game are still in an early beta state, and using them may cause loss of time, data and/or sanity. Use it at your own risk.
## Available editors (22/7/21)
- Level (map) editor - Create & edit maps, with unit placements and objectives.
- Tileset editor - Create & edit tilesets, including their graphics, gameplay data and battle backgrounds.
- Level metadata editor - Edit miscellaneous level data, such as team palettes, team AIs and music.
- Conversation (event) editor - Create & edit conversations (events), with color-coded parts & commands (without documentation).
- Class & unit editor - Create & edit classes: name, stats, sprite and battle animations. Also includes a unit editor: name, class, growths and inclination.
- Portrait editor - Create & edit portraits, both generic and character-based.
## Quick-start guide
I will probably add an easier way to use this tool in the future, but this is the current system:
1. Install Visual Studio, Unity, and clone [Utils](../../../Utils).
2. Clone [Frogman Gaiden](../../../FrogmanGaiden) and Frog Forge (this repository).
3. Build Frog Forge with Visual Studio (import Utils and any other dependency).
4. In Frog Forge, locate Frogman Gaiden's project data folder (should be `[RepoFolder]\Assets\Data`).
5. In Frog Forge, import the Frog Forge data (should be `[RepoFolder]\Data.zip`).
6. Frog Forge is now ready! Edit stuff to your heart's content.
7. Open Frogman Gaiden in Unity, and import the new data by using the FrogForgeImporter object in the Map and Menu scenes (use the "Load X" buttons).
8. Finally, build Frogman Gaiden. You will now have a ready-to-use .exe file (or Mac or Linux build) of the edited game. That's it!
