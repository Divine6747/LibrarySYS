# LibrarySYS - Unified Contribution Script

# Clone the repository and go into it

  # If you want to clone it in a folder
  git clone https://github.com/Divine6747/LibrarySYS.git
  cd LibrarySYS

  # If you want to clone on VS
  Open VS --> Clone a Repository 
  git clone https://github.com/Divine6747/LibrarySYS.git
  Click --> Clone
  

# Open project in Visual Studio or VS Code
# Ensure all dependencies are installed

# Make sure you are on main and pull the latest changes
git checkout main
git pull origin main

# If starting a new feature, create a branch
git checkout -b <your-feature-branch>

# Keep your branch up-to-date with main before making changes
git fetch origin
git merge origin/main
# Resolve any merge conflicts if they appear

# Make your changes (edit files, create folders, etc.)
# After editing, stage all changes
git add .

# Commit changes with a clear message
git commit -m "Created new folder and moved items to make it easier to manage"

# Push your branch to the remote repository
git push origin <your-feature-branch>

# To ensure your branch includes the latest main commits, merge main again
git fetch origin
git merge origin/main
# Resolve conflicts if necessary

# If you need to update other branches with this commit (like Heta or Martin):
git checkout Heta
git merge main
git push origin Heta

git checkout Martin
git merge main
git push origin Martin

# Avoid using --force on shared branches
# Only force push on personal branches after coordinating with the team

# Once your branch is ready, open a Pull Request to merge into main
# Ensure tests pass and all conflicts are resolved before merging

# Visual representation of branches:
# main   ──●────●────●─────────> (stable)
#          \
# Heta       ●────●────────────────> (feature branch, sync with main)
# Martin     ●────●────●───────────> (feature branch, sync with main)

# Quick summary workflow:
 1. git fetch origin
 2. git checkout <your-branch>
 3. git merge origin/main
 4. git add .
 5. git commit -m "Your commit message"
 6. git push origin <your-branch>
 7. Open PR to merge into main
