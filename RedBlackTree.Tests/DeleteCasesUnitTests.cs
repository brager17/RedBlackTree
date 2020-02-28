using RedBlackTreeStructure;
using Xunit;

namespace ConsoleApp1.Tests.CustomDictionary.Tests
{
    public class DeleteCasesUnitTests
    {
        [Fact]
        public void Case1Test()
        {
            var any = 0;
            var a = any;
            var b = any;
            var c = any;
            var d = any;
            var nd = new RedBlackTree.Node()
            {
                Value = a,
                Color = RedBlackTree.Color.Black,
                Right = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Red,
                    Value = b,
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = d
                    },
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = c
                    }
                }
            };

            var tree = new RedBlackTree(nd);
            tree.Case1(nd.Left, nd.Left.Sibling());

            var expected = new RedBlackTree.Node()
            {
                Value = b,
                Color = RedBlackTree.Color.Black,
                Left = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Red,
                    Value = a,
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = c
                    },
                },
                Right = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = d
                }
            };

            Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
        }

        [Fact]
        public void Case2Test()
        {
            var any = 0;
            var a = any;
            var b = any;
            var c = any;
            var d = any;
            var nd = new RedBlackTree.Node()
            {
                Value = a,
                Color = RedBlackTree.Color.Black,
                Left = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Red,
                    Value = b,
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = d
                    },
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = c
                    }
                }
            };

            var tree = new RedBlackTree(nd);
            tree.Case2(nd.Right, nd.Right.Sibling());

            var expected = new RedBlackTree.Node()
            {
                Value = b,
                Color = RedBlackTree.Color.Black,
                Right = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Red,
                    Value = a,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = d
                    },
                },
                Left = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = c
                }
            };

            Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
        }

        [Fact]
        public void Case3Test()
        {
            var any = 0;
            var a = any;
            var b = any;
            var c = any;
            var d = any;

            void ColorDepends(RedBlackTree.Color color)
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = color,
                    Value = a,
                    Right = new RedBlackTree.Node()
                    {
                        Value = b,
                        Color = RedBlackTree.Color.Black,
                        Right = new RedBlackTree.Node()
                        {
                            Value = d,
                            Color = RedBlackTree.Color.Black
                        },
                        Left = new RedBlackTree.Node()
                        {
                            Color = RedBlackTree.Color.Red,
                            Value = c
                        }
                    }
                };

                var tree = new RedBlackTree(nd);
                tree.Case3(nd.Left, nd.Left.Sibling());
                var expected = new RedBlackTree.Node()
                {
                    Color = color,
                    Value = a,
                    Right = new RedBlackTree.Node()
                    {
                        Value = c,
                        Color = RedBlackTree.Color.Black,
                        Right = new RedBlackTree.Node()
                        {
                            Value = b,
                            Color = RedBlackTree.Color.Red,
                            Right = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Black,
                                Value = d
                            }
                        }
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            ColorDepends(RedBlackTree.Color.Red);
            ColorDepends(RedBlackTree.Color.Black);
        }

        [Fact]
        public void Case4()
        {
            var any = 0;
            var a = any;
            var b = any;
            var c = any;
            var d = any;

            void ColorDepends(RedBlackTree.Color color)
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = color,
                    Value = a,
                    Left =
                        new RedBlackTree.Node()
                        {
                            Value = b,
                            Color = RedBlackTree.Color.Black,
                            Left = new RedBlackTree.Node()
                            {
                                Value = d,
                                Color = RedBlackTree.Color.Black
                            },
                            Right = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Red,
                                Value = c
                            }
                        }
                };

                var tree = new RedBlackTree(nd);
                tree.Case4(nd.Right, nd.Right.Sibling());
                var expected = new RedBlackTree.Node()
                {
                    Color = color,
                    Value = a,
                    Left = new RedBlackTree.Node()
                    {
                        Value = c,
                        Color = RedBlackTree.Color.Black,
                        Left = new RedBlackTree.Node()
                        {
                            Value = b,
                            Color = RedBlackTree.Color.Red,
                            Left = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Black,
                                Value = d
                            }
                        }
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            ColorDepends(RedBlackTree.Color.Red);
            ColorDepends(RedBlackTree.Color.Black);
        }

        [Fact]
        public void Case5()
        {
            var any = 0;
            var a = any;
            var b = any;
            var c = any;
            var d = any;

            void ColorDepends(RedBlackTree.Color color)
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = color,
                    Value = a,
                    Right =
                        new RedBlackTree.Node()
                        {
                            Value = b,
                            Color = RedBlackTree.Color.Black,
                            Right = new RedBlackTree.Node()
                            {
                                Value = d,
                                Color = RedBlackTree.Color.Black
                            },
                            Left = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Black,
                                Value = c
                            }
                        }
                };

                var tree = new RedBlackTree(nd);
                tree.Case5(nd.Left, nd.Left.Sibling());
                var expected = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = a,
                    Right = new RedBlackTree.Node()
                    {
                        Value = b,
                        Color = RedBlackTree.Color.Red,
                        Left = new RedBlackTree.Node()
                        {
                            Value = c,
                            Color = RedBlackTree.Color.Black
                        },
                        Right = new RedBlackTree.Node()
                        {
                            Value = d,
                            Color = RedBlackTree.Color.Black,
                        }
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            ColorDepends(RedBlackTree.Color.Red);
            ColorDepends(RedBlackTree.Color.Black);
        }

        [Fact]
        public void Case6()
        {
            var any = 0;
            var a = any;
            var b = any;
            var c = any;
            var d = any;

            void ColorDepends(RedBlackTree.Color color)
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = color,
                    Value = a,
                    Left =
                        new RedBlackTree.Node()
                        {
                            Value = b,
                            Color = RedBlackTree.Color.Black,
                            Left = new RedBlackTree.Node()
                            {
                                Value = d,
                                Color = RedBlackTree.Color.Black
                            },
                            Right = new RedBlackTree.Node()
                            {
                                Color = RedBlackTree.Color.Black,
                                Value = c
                            }
                        }
                };

                var tree = new RedBlackTree(nd);
                tree.Case6(nd.Right, nd.Right.Sibling());
                var expected = new RedBlackTree.Node()
                {
                    Color = RedBlackTree.Color.Black,
                    Value = a,
                    Left = new RedBlackTree.Node()
                    {
                        Value = b,
                        Color = RedBlackTree.Color.Red,
                        Right = new RedBlackTree.Node()
                        {
                            Value = c,
                            Color = RedBlackTree.Color.Black
                        },
                        Left = new RedBlackTree.Node()
                        {
                            Value = d,
                            Color = RedBlackTree.Color.Black,
                        }
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            ColorDepends(RedBlackTree.Color.Red);
            ColorDepends(RedBlackTree.Color.Black);
        }

        [Fact]
        public void Case7()
        {
            var any = 0;
            var a = any;
            var b = any;
            var c = any;
            var d = any;

            void ColorDepends(RedBlackTree.Color colorA, RedBlackTree.Color colorC)
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = colorA,
                    Value = a,
                    Right =
                        new RedBlackTree.Node()
                        {
                            Value = b,
                            Color = RedBlackTree.Color.Black,
                            Right = new RedBlackTree.Node()
                            {
                                Value = d,
                                Color = RedBlackTree.Color.Red
                            },
                            Left = new RedBlackTree.Node()
                            {
                                Value = c,
                                Color = colorC
                            }
                        }
                };

                var tree = new RedBlackTree(nd);
                tree.Case7(nd.Left, nd.Left.Sibling());
                var expected = new RedBlackTree.Node()
                {
                    Color = colorA,
                    Value = b,
                    Right = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = d
                    },
                    Left = new RedBlackTree.Node()
                    {
                        Value = a,
                        Color = RedBlackTree.Color.Black,
                        Right = new RedBlackTree.Node()
                        {
                            Value = c,
                            Color = colorC
                        },
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            ColorDepends(RedBlackTree.Color.Red, RedBlackTree.Color.Red);
            ColorDepends(RedBlackTree.Color.Red, RedBlackTree.Color.Black);
            ColorDepends(RedBlackTree.Color.Black, RedBlackTree.Color.Red);
            ColorDepends(RedBlackTree.Color.Black, RedBlackTree.Color.Black);
        }

        [Fact]
        public void Case8()
        {
            var any = 0;
            var a = any;
            var b = any;
            var c = any;
            var d = any;

            void ColorDepends(RedBlackTree.Color colorA, RedBlackTree.Color colorC)
            {
                var nd = new RedBlackTree.Node()
                {
                    Color = colorA,
                    Value = a,
                    Left =
                        new RedBlackTree.Node()
                        {
                            Value = b,
                            Color = RedBlackTree.Color.Black,
                            Left = new RedBlackTree.Node()
                            {
                                Value = d,
                                Color = RedBlackTree.Color.Red
                            },
                            Right = new RedBlackTree.Node()
                            {
                                Value = c,
                                Color = colorC
                            }
                        }
                };

                var tree = new RedBlackTree(nd);
                tree.Case8(nd.Right, nd.Right.Sibling());
                var expected = new RedBlackTree.Node()
                {
                    Color = colorA,
                    Value = b,
                    Left = new RedBlackTree.Node()
                    {
                        Color = RedBlackTree.Color.Black,
                        Value = d
                    },
                    Right = new RedBlackTree.Node()
                    {
                        Value = a,
                        Color = RedBlackTree.Color.Black,
                        Left = new RedBlackTree.Node()
                        {
                            Value = c,
                            Color = colorC
                        },
                    }
                };

                Assert.Equal(expected, tree._root, RedBlackTree.NodeEqualityComparer.Comparer);
            }

            ColorDepends(RedBlackTree.Color.Red, RedBlackTree.Color.Red);
            ColorDepends(RedBlackTree.Color.Red, RedBlackTree.Color.Black);
            ColorDepends(RedBlackTree.Color.Black, RedBlackTree.Color.Red);
            ColorDepends(RedBlackTree.Color.Black, RedBlackTree.Color.Black);
        }
    }
}