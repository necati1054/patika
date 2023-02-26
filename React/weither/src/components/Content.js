import { Container } from "@mui/material";
import React from "react";
import CountrySelect from "./page/CountrySelect";
import Days from "./page/Days";
import Footer from "./page/Footer";
import "../App.css";


function Content() {
    return (
        <>
            <CountrySelect />
            <Days />
            <Footer />
        </>
    );
}


export default Content;