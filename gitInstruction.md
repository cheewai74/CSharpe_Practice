bash# Initialize the local directory as a Git repository
git init

# Stage all files in your project directory
git add .

# Commit the staged files with a message
git commit -m "Initial commit"

# Rename your default branch to 'main' (matches GitHub's standard)
git branch -M main

# Associate your local repository with the GitHub remote repository
git remote add origin <PASTE_YOUR_GITHUB_REPOSITORY_URL>
git remote add origin CSHARPE_PRACTICE

# Push the code from your local main branch to GitHub
git push -u origin main