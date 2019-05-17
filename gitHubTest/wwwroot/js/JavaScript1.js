export let users = ["minsoeng", "dal", "minA"];
export const addUsers = (user) => users = [...users, user];
export const getUsers = () => users;
export const deleteUSer = (user) => users = users.filter(aUser => aUser !== user);

