#!/bin/bash
# push-to-github.sh

# Exit immediately if a command exits with a non-zero status
set -e

# Check if .git exists
if [ ! -d ".git" ]; then
  echo "Initializing git repository..."
  git init
fi

# Add remote if not already present
if ! git remote | grep -q origin; then
  git remote add origin https://github.com/hija-happy-sgx/RecipeApp-MVC-CodeFirst.git
fi

# Set branch to main
git branch -M main

# Stage all files
git add .

# Commit changes
git commit -m "first commit"

# Push to GitHub
git push -u origin main

echo "✅ Code pushed successfully!"
