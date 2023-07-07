# CMS_Sommer2023

## Description
I tend to have a project for sommer holiday. I do it so i keep my skills somewhat even if not improving. 
This sommer project is going to be a CMS (Content Management System), i will do the frontend in JS and using the framework Vue.js. For the backend i will use C#, REST API (C#), MS SQL. I will test out Azure DevOps in this project aswell, for the first time. 
I will update this when/if i use more, if i remember... :) 

This project will be about ...

## Note
When i say [semi new for me], i mean i have done it a few times/ones before, but hardly remember it and likely was done in a different langauge and framework/template
The following lists points is not in any order.

## Overall content that i want to make
1. Content Creation and Editing (CRUD) [done before]
2. Content Publishing/scheduling [new for me]
3. User Management and Permissions (user authentication and role-based access control) [semi new for me]
4. Media Management [semi new for me]
5. Responsive Design [done before]

 ## Overall content that i might want to check out
 1. Multilingual Support [new for me]


## TASK

### Preparation
- [] set up base MS SQL database
- [] set up base REST API
- [] set up start Vue.js

### 1. Content Creation and Editing (CRUD)
Authorized users can create and modify content through a user-friendly page. content will be stored in a database
- [] make REST GetAll call response
- - [] make test for the GetAll call and content
- [] create site for showing content

- [] make REST Create call response
- - [] make test for the Create call and content
- [] create site for creating content

- [] make REST Update call response
- - [] make test for the Update call and content
- [] create site for updating content

- [] make REST Delete call response
- - [] make test for the Delete call and content
- [] create site for deleting content

### 2. Content Publishing/scheduling [new for me]
Authorized users can choose when a CRUD change will happen.
- no clue
### 3. User Management and Permissions (user authentication and role-based access control) [semi new for me]
Making a create user system with login/logout. There will be diffrent roles, so users have diffrent access. 
The roles:
> - Customer - This role will be given all new profiles.
> - Worker - This will be given to the people that work with the CMS system.
> - Creater - This will be given to the people that will make CRUD changes.
> - Admin - This will be given to the person(s) that will maintaine the system.
> - Super Admin - This will be given to the creator.


| **Roles** | **Customer** | **Worker** | **Creater** | **Admin** | **Super Admin** |
| --------- | ------------ | ---------- | ----------- | --------- | --------------- |
| Viewing content | X | X |  X |  X |  X |
| Creating content | | | X | X | X |
| Update content | | | X | X | X |
| Delete content | | | X | X | X |
| Looking at orders | X (only their own) | X | | X | X |
| Change user roles | | | | X | X |

### 4. Media Management [semi new for me]
Storing and manipulate the media (for now just pictures) that is being uploaded to a content item.


### 5. Responsive Design [done before]
Making the site to be scaleable visually.