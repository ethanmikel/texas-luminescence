Terminal Commands

Running a Local Host 
npm run dev

Pulling from the Git Repo
git pull

Viewing Current Live Branches 
git branch 

Creating a New Branch 
git checkout -b <branch-name>(e.g. git branch ethan-navbar)

Going from Branch to Branch 
git checkout <branch-name> (e.g. git checkout ethan-navbar) 

Merging a Branch to Main 
git checkout main 
git pull 
git checkout <BRANCH> 
git merge main 
git push 

:wq

(If merge conflicts arise, contact Ethan if you can’t resolve them on your own) 

Deleting Branches Not Found on the Repo 
git checkout main
git pull
git remote prune origin 
git fetch --all -p; git branch -vv | grep “:gone]“ awk ‘{ print $1 }‘  | xargs -n 1 git branch -D

Reset the Last Commit (Use for Merge Conflicts) 
git reset --hard head~1

Resources Help
npm --v

npm --help

Cloning a Git Repository
Click the link to the repo
Click “<> Code” and Copy url 
Open terminal 
Change working directory to wherever you want 
git clone <copied url>

