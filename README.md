# Frog Forge
A work-in-progress game editor for [Frogman Magmaborn](../../../FrogmanMagmaborn). Both the editor & game are still in an early beta state, and using them may cause loss of time, data and/or sanity. Use it at your own risk.
## Available editors (20/11/21)
- Map editor - Create & edit maps, with unit placements, objectives and mid-map events.
- Tileset editor - Create & edit tilesets, including their graphics, gameplay data and battle backgrounds.
- Level metadata editor - Edit miscellaneous level data, such as team palettes, team AIs and music.
- Class & unit editor - Create & edit classes: name, stats, sprite and battle animations. Also includes a unit editor: name, class, growths, inclination and death quotes.
- Portrait editor - Create & edit portraits, both generic and character-based.
- Conversation (event) editor - Create & edit conversations (events), with color-coded parts & commands (without documentation) and a built-in preview player.
- CG editor - Create & edit conversation backgrounds.
## Using Frog Forge
Currently, using Frog Forge requires building it and installing Unity. I will add a moddable version of Frogman Magmaborn in the future, which won't require Unity.
For now, however, here's a "quick"-start guide:
1. Install Visual Studio, Unity, and clone [Utils](../../../Utils).
2. Clone [Frogman Magmaborn](../../../FrogmanMagmaborn) and Frog Forge (this repository).
3. Build Frog Forge with Visual Studio (import Utils and any other dependency).
4. In Frog Forge, locate Frogman Magmaborn's project data folder (should be `[Frogman Magmaborn repo folder]\Assets\Data`).
5. In Frog Forge, import the Frog Forge data (should be `[Frogman Magmaborn repo folder]\Data.zip`).
6. Frog Forge is now ready! Edit stuff to your heart's content.
7. Open Frogman Magmaborn in Unity, and import the new data by using the FrogForgeImporter object in the Map and Menu scenes (use the "Load X" buttons), and the Battle prefab.
8. Finally, build Frogman Magmaborn. You will now have a ready-to-use .exe file (or Mac or Linux build) of the edited game. That's it!
