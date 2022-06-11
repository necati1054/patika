import axios from "axios";

export const getData = async(userID) =>
{
    const { data:user } = await axios("https://jsonplaceholder.typicode.com/users/"+userID);
    const { data:post } = await axios("https://jsonplaceholder.typicode.com/posts/"+userID);
    console.log("user",user);
    console.log("post",post);
}
