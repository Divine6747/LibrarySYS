# Contributing Guidelines

## Branching Strategy
- **Main branch (`main`)**: Stable branch where all completed and reviewed features are merged.
- **Feature branches**: Create separate branches for your work (e.g., `Heta`, `Martin`). Avoid committing directly to `main`.
- **Short-lived branches**: Keep branches for specific tasks or features. Merge them back when complete.

---

## Keeping Your Branch Up-to-Date
Before starting work or pushing your branch:

```bash
# Fetch the latest changes from remote
git fetch origin

# Switch to your branch
git checkout <your-branch>

# Merge the latest main into your branch
git merge origin/main
