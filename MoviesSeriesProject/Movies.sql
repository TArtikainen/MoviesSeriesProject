--
-- PostgreSQL database dump
--

-- Dumped from database version 12.0
-- Dumped by pg_dump version 12.0

-- Started on 2020-01-13 13:48:28

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 203 (class 1259 OID 25029)
-- Name: moviegenre; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.moviegenre (
    idgenre integer NOT NULL,
    genre character varying(255)
);


ALTER TABLE public.moviegenre OWNER TO postgres;

--
-- TOC entry 202 (class 1259 OID 25027)
-- Name: genre_idgenre_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.genre_idgenre_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.genre_idgenre_seq OWNER TO postgres;

--
-- TOC entry 2836 (class 0 OID 0)
-- Dependencies: 202
-- Name: genre_idgenre_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.genre_idgenre_seq OWNED BY public.moviegenre.idgenre;


--
-- TOC entry 205 (class 1259 OID 25058)
-- Name: moviedb; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.moviedb (
    id integer NOT NULL,
    title character varying(255),
    releaseyear integer,
    director character varying(255),
    writers character varying(255),
    stars character varying(255),
    genreid integer,
    productionperiods integer
);


ALTER TABLE public.moviedb OWNER TO postgres;

--
-- TOC entry 204 (class 1259 OID 25056)
-- Name: moviedb_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.moviedb_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.moviedb_id_seq OWNER TO postgres;

--
-- TOC entry 2837 (class 0 OID 0)
-- Dependencies: 204
-- Name: moviedb_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.moviedb_id_seq OWNED BY public.moviedb.id;


--
-- TOC entry 2695 (class 2604 OID 25061)
-- Name: moviedb id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.moviedb ALTER COLUMN id SET DEFAULT nextval('public.moviedb_id_seq'::regclass);


--
-- TOC entry 2694 (class 2604 OID 25032)
-- Name: moviegenre idgenre; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.moviegenre ALTER COLUMN idgenre SET DEFAULT nextval('public.genre_idgenre_seq'::regclass);


--
-- TOC entry 2830 (class 0 OID 25058)
-- Dependencies: 205
-- Data for Name: moviedb; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (7, 'Rita Hayworth - Avain pakoon', 1995, 'Frank Darabont', 'Tim Robbins, Morgan Freeman, Bob Gunton', 'Stephen King (short story "Rita Hayworth and Shawshank Redemption"), Frank Darabont (screenplay)', 6, 0);
INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (9, 'The Godfather - Kummisetä', 1972, 'Francis Ford Coppola', 'Marlon Brando, Al Pacino, James Caan', 'Mario Puzo (screenplay by), Francis Ford Coppola (screenplay by),Mario Puzo (based on the novel by)', 10, 0);
INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (10, 'The Dark Knight - Yön ritari', 2008, 'Christopher Nolan', 'Christian Bale, Heath Ledger, Aaron Eckhart', 'Jonathan Nolan (screenplay), Christopher Nolan (screenplay), Christopher Nolan(story) & David S. Goyer(story),Bob Kane(characters)', 3, 0);
INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (11, '12 Angry Men - Valamiesten ratkaisu', 1957, 'Sidney Lumet', 'Henry Fonda, Lee J. Cobb, Martin Balsam', 'Reginald Rose (story), Reginald Rose (screenplay)', 6, 0);
INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (12, 'Schindler''s List - Schindlerin lista', 1993, 'Steven Spielberg', 'Liam Neeson, Ralph Fiennes, Ben Kingsley', 'Thomas Keneally (book), Steven Zaillian (screenplay)', 6, 0);
INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (13, 'The Lord of the Rings: The Return of the King - Taru sormusten herrasta: Kuninkaan paluu', 2003, 'Peter Jackson', 'Elijah Wood, Viggo Mortensen, Ian McKellen', 'J.R.R. Tolkien (novel), Fran Walsh (screenplay), Philippa Boyens(screenplay), Peter Jackson(screenplay)', 12, 0);
INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (14, 'Pulp Fiction - Tarinoita väkivallasta', 1994, 'Quentin Tarantino', 'John Travolta, Uma Thurman, Samuel L. Jackson', 'Quentin Tarantino (stories), Roger Avary (stories), Quentin Tarantino (written by) ', 10, 0);
INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (17, 'Forrest Gump', 1994, 'Robert Zemeckis', 'Tom Hanks, Robin Wright, Gary Sinise', 'Winston Groom (novel), Eric Roth (screenplay)', 6, 0);
INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (18, 'Band of Brothers - Taistelutoverit', 2001, 'David Frankel,Mikael Salomon,Tom Hanks,David Leland,Richard Loncraine,David Nutter,Phil Alden Robinson,Tony To', 'Scott Grimes, Damian Lewis, Ron Livingston', 'Stephen Ambrose,Erik Bork,E. Max Frye,Tom Hanks,Erik Jendresen,Bruce C. McKenna,John Orloff,Graham Yost', 6, 1);
INSERT INTO public.moviedb (id, title, releaseyear, director, writers, stars, genreid, productionperiods) VALUES (19, 'Chernobyl', 2019, 'Johan Renck', 'Jessie Buckley, Jared Harris, Stellan Skarsgård', 'Craig Mazin', 6, 1);


--
-- TOC entry 2828 (class 0 OID 25029)
-- Dependencies: 203
-- Data for Name: moviegenre; Type: TABLE DATA; Schema: public; Owner: postgres
--

INSERT INTO public.moviegenre (idgenre, genre) VALUES (1, 'Comedy');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (2, 'Thriller');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (3, 'Action');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (4, 'Romance');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (5, 'Horror');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (6, 'Drama');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (7, 'Sci-Fi');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (8, 'Superhero');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (9, 'Mystery');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (10, 'Crime');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (11, 'Animation');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (12, 'Adventure');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (13, 'Fantasy');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (14, 'Comedy-Romance');
INSERT INTO public.moviegenre (idgenre, genre) VALUES (15, 'Action-Comedy');


--
-- TOC entry 2838 (class 0 OID 0)
-- Dependencies: 202
-- Name: genre_idgenre_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.genre_idgenre_seq', 1, false);


--
-- TOC entry 2839 (class 0 OID 0)
-- Dependencies: 204
-- Name: moviedb_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.moviedb_id_seq', 19, true);


--
-- TOC entry 2697 (class 2606 OID 25034)
-- Name: moviegenre genre_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.moviegenre
    ADD CONSTRAINT genre_pkey PRIMARY KEY (idgenre);


--
-- TOC entry 2699 (class 2606 OID 25066)
-- Name: moviedb moviedb_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.moviedb
    ADD CONSTRAINT moviedb_pkey PRIMARY KEY (id);


--
-- TOC entry 2700 (class 2606 OID 25067)
-- Name: moviedb genrefk; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.moviedb
    ADD CONSTRAINT genrefk FOREIGN KEY (genreid) REFERENCES public.moviegenre(idgenre) NOT VALID;


-- Completed on 2020-01-13 13:48:29

--
-- PostgreSQL database dump complete
--

