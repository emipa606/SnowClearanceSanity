# GitHub Copilot Instructions for Snow Clearance Sanity (Continued)

## Mod Overview and Purpose
Snow Clearance Sanity (Continued) is a mod for RimWorld that improves the experience of managing snow clearing tasks in the game. Originally created by MarvinKosh and now maintained with permission, this mod prevents colonists from becoming trapped in an endless loop of clearing snow when it is actively snowing. By reducing the priority of snow clearing, the mod ensures that more urgent tasks, such as cleaning dirt, are addressed first. Users have the flexibility to manually prioritize snow clearing if needed.

## Key Features and Systems
- **Snow Clearing Management:** Colonists no longer give undue priority to clearing snow while snow continues to fall.
- **Task Prioritization Adjustment:** By default, snow clearing tasks are deprioritized, ensuring that cleaning tasks are addressed first.
- **User Control:** Players can still manually prioritize snow clearing tasks if required.

## Coding Patterns and Conventions
- **C# Best Practices:** The mod uses idiomatic C# patterns and is organized into separate classes for clarity and maintainability. 
- **Type Naming Conventions:** Classes and members use PascalCase, making them easy to read and understand.
- **Comments and Documentation:** Ensure to add comments in areas where the code may not be self-explanatory.

## XML Integration
- **Patch Syntax:** XML files are used for patching default game behaviors. The `LowerPrioritySnowClearance.xml` file utilizes XML patching to lower the default priority of snow clearing tasks.
- **XML Structure:** The XML format adheres to the expected structure needed for RimWorld mod integration, ensuring compatibility with base game systems.

## Harmony Patching
- **Harmony Integration:** The mod uses the Harmony library (`brrainz.harmony`) to safely patch and alter game methods.
- **Postfix Patch Example:** In `WorkGiver_ClearSnowOrSand_HasJobOnCell.cs`, a postfix patch is used to modify the behavior after the default game function has run.

## Suggestions for Copilot
- **Code Completion:** Use GitHub Copilot to help with generating repetitive code blocks, such as adding additional jobs or expanding XML patches.
- **Error Handling:** Implement Copilot suggestions to improve error handling in C# for edge cases not currently covered.
- **Documentation:** Utilize Copilot to draft initial documentation comments within the codebase and expand upon those with specific details.

### C# Files Overview
- **WorkGiver_ClearSnowOrSand_HasJobOnCell.cs**
  - **Key Type:** WorkGiver_ClearSnowOrSand_HasJobOnCell
  - **Key Members:** Postfix
- **SnowClearanceSanity.cs**
  - **Key Type:** SnowClearanceSanity
  - **Key Members:** SnowClearanceSanity

### XML Files Overview
- **LowerPrioritySnowClearance.xml:** Contains patches for modifying task priorities related to snow clearance.

## Further Information and Support
For detailed information and direct download links, please visit the Ludeon Forums. Any bug reports or troubleshooting should be done via Discord for real-time support. If you have found a solution to any issue, contribute by posting it on the GitHub repository to assist others.

Please use RimSort to sort your mods to ensure compatibility and proper functionality.

### Note on Mod Updates
Refrain from commenting to inquire about mod updates. Follow my social media channels for any announcements regarding updates to the mod.

Thank you for using Snow Clearance Sanity (Continued), and enjoy a more streamlined RimWorld experience!

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

