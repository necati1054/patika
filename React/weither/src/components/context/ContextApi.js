import { createContext, useContext, useState } from "react";
import cities from "../../data/cities.json";
const WeatherContext = createContext();

export const WeatherProvider = ({ children }) => {
    const [weather, setWeather] = useState([]);
    const [city, setCity] = useState(
        cities.find((item) => item.name === "Denizli")
    );
    const value = { city, setCity, cities, weather, setWeather };
    return (
        <WeatherContext.Provider value={value}>{children}</WeatherContext.Provider>
    );
};

export const useWeather = () => useContext(WeatherContext);