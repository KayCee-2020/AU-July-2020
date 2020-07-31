const express = require("express");

const app = express();
const bodyparser = require("body-parser");

const port = process.env.PORT || 3200;

app.use(bodyparser.json());
app.use(bodyparser.urlencoded({ extended: false }));

var todoList = [];

app.get('/Tasks', (req, res) => {
  res.status(200).send(todoList);
});

app.post('/Add', (req, res) => {
    const task = req.body.new;

    console.log(task);
    todoList.push(task);

    return res.json('Task is added to the List');
});

app.put('/Edit', (req,res)=>{
	const task = req.body.new;
	const id = todoList.indexOf(task);
	console.log(id);
	if(id==-1){
		res.send("NOT FOUND !!");
	}
	else{
		todoList.splice(id,1,req.body.edited);
	}
});

app.delete('/Remove' ,(req,res)=> {
	const task = req.body.task;
	const id = todoList.indexOf(task);
	if(id == -1){
		res.send("NOT FOUND !!");
	}
	else{
		todoList.splice(id,1);
		res.send("deleted one task");
	}
});
app.listen(port, () => {
  console.log(`running at port ${port}`);
});