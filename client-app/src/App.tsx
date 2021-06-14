import React, { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() =>
    {
      axios.get('https://localhost:44382/api/Activities')
      .then(
        response => {
          console.log(response);
          setActivities(response.data);
        }
      )     
    }, []
  );

  return (
    <div className="App">
      <Header as='h1'>Kekekek</Header>
      <List>
        {activities.map((activity : any) => 
        (
          <List.Item key={activity.id}>{activity.title}</List.Item>
        ))}
      </List>
    </div>
  );
}

export default App;