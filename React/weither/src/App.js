import { Container, Grid } from '@mui/material';
import Content from './components/Content';
import { WeatherProvider } from './components/context/ContextApi';

function App() {
  return (
    <Container>
      <Grid container>
        <Grid item xs={12} mt={1}>
          <WeatherProvider >
            <Content />
          </WeatherProvider>
        </Grid>
      </Grid>
    </Container>
  );
}

export default App;
