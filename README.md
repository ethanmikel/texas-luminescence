# Group-6

## Terminal Commands

#### Pulling from the Git Repo
git pull

#### Viewing Current Live Branches 
git branch 

#### Creating a New Branch 
git checkout -b <branch-name>(e.g. git branch ethan-navbar)

#### Going from Branch to Branch 
git checkout <branch-name> (e.g. git checkout ethan-navbar) 

#### Merging a Branch to Master 
git checkout master <BR>
git pull <BR>
git checkout <BRANCH> <BR>
git merge master <BR>
git push 

:wq

(If merge conflicts arise, contact Ethan if you can’t resolve them on your own) 

#### Deleting Branches Not Found on the Repo 
git checkout master <BR>
git pull <BR>
git remote prune origin <BR>
git fetch --all -p; git branch -vv | grep “:gone]“ awk ‘{ print $1 }‘  | xargs -n 1 git branch -D

#### Reset the Last Commit (Use for Merge Conflicts) 
git reset --hard head~1

#### Cloning a Git Repository
Click the link to the repo
Click “<> Code” and Copy url 
Open terminal 
Change working directory to wherever you want 
git clone <copied url>


#### ef Migration to Azure
dotnet ef migrations add <title>
dotnet ef database update -v
